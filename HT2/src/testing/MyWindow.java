package testing;
import javax.swing.*;
import java.awt.event.*; 
import java.awt.*;

public class MyWindow extends JFrame
    {/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JTextField txtIDnum,txtName,txtEMail;
     private JLabel lbl_IDNumber, lbl_Name,lbl_Gender,lbl_CivilStatus,lbl_EMail;
     private JButton btnSave,btnSearch,btnRemove,btnClose,btnNew;
     private JComboBox<?> CmbGender,CmbCivilStatus;
     String[] Gender = { "","Male", "Female"};
	 String[] CivilStatus = { "","Single", "Married","Complicated"};
     

     @SuppressWarnings("deprecation")
	public MyWindow()
     { super("File Handling"); 
         Container Win = getContentPane(); 
         Win.setLayout(null);

         lbl_IDNumber = new JLabel("ID Number:  ");
         lbl_Name = new JLabel("Name : ");
		 lbl_Gender = new JLabel("Gender : ");
		 lbl_CivilStatus = new JLabel("Civil Status:");
		 lbl_EMail = new JLabel("Email Address:");

         txtIDnum = new JTextField(10);
         txtName = new JTextField(10);
	     CmbGender = new JComboBox<Object>(Gender); 
		 CmbCivilStatus = new JComboBox<Object>(CivilStatus); 
		 txtEMail = new JTextField(10);
         
         btnNew = new JButton("ADD NEW");
	     btnSave = new JButton("   SAVE   ");
         btnSearch = new JButton("   SEARCH   ");
	     btnRemove = new JButton(" REMOVE ");
         btnClose = new JButton("   CLOSE   ");

//-------------------------------------------Set Objects Location------------------------------------------------------------------------------------------------					  

         Win.add(lbl_IDNumber);   	lbl_IDNumber.setBounds(115, 10, 120, 25);
         Win.add(txtIDnum);  		txtIDnum.setBounds(220, 10, 150, 25); 
         Win.add(lbl_Name);    		lbl_Name.setBounds(115, 40, 120, 25);
         Win.add(txtName);    		txtName.setBounds(220, 40, 150, 25); 
         Win.add(lbl_Gender); 	    lbl_Gender.setBounds(115, 70, 120, 25);
         Win.add(CmbGender);  		CmbGender.setBounds(220, 70, 150, 25);
		 Win.add(lbl_CivilStatus); 	lbl_CivilStatus.setBounds(115, 100, 120, 25);
         Win.add(CmbCivilStatus);  	CmbCivilStatus.setBounds(220, 100, 150, 25);
		 Win.add(lbl_EMail); 	    lbl_EMail.setBounds(115, 130, 120, 25);
         Win.add(txtEMail);  	    txtEMail.setBounds(220, 130, 150, 25);

   	     Win.add(btnNew);     btnNew.setBounds(5, 10, 100, 25);
         Win.add(btnSave);    btnSave.setBounds(5, 40, 100, 25);
         Win.add(btnSearch);  btnSearch.setBounds(5, 70, 100, 25);
	     Win.add(btnRemove);  btnRemove.setBounds(5, 100, 100, 25);
         Win.add(btnClose);   btnClose.setBounds(5, 130, 100, 25);
		 setSize(380,200);
         show();
		 txtIDnum.requestFocus();

//-----------------------------------------Button New-------------------------------------------------------         
		  btnNew.addActionListener ( new ActionListener()
                     {  public void actionPerformed(ActionEvent e)
                        {  Clear_Control();
						   txtIDnum.setText(Student.GetNew_IDNumber());
                           txtName.requestFocus();
				     }} );

//-----------------------------------------Button Save-------------------------------------------------------         
		  btnSave.addActionListener ( new ActionListener()
                     {  public void actionPerformed(ActionEvent e)
                        {  Student.setIDNumber(txtIDnum.getText());
                           Student.setName(txtName.getText());
						   Student.setGender((String)CmbGender.getSelectedItem());
						   Student.setCivilStatus((String)CmbCivilStatus.getSelectedItem());
						   Student.setEmail(txtEMail.getText());
				           Student.AddNew();
                         JOptionPane.showMessageDialog(null,"Record is already Saved!!!", "Saving",JOptionPane.INFORMATION_MESSAGE);
                      }} );
//------------------------------------------Button Search-------------------------------------------------------------------------------------------------- 
		 btnSearch.addActionListener ( new ActionListener()
                     {  public void actionPerformed(ActionEvent e)
                        { Student.Search_IDNumber(txtIDnum.getText());
						   if (Student.isRecordFound==true)
						    {txtIDnum.setText(Student.getIDNumber());
                             txtName.setText(Student.getName());
						     CmbGender.setSelectedItem(Student.getGender());
							 CmbCivilStatus.setSelectedItem(Student.getCivilStatus());
							 txtEMail.setText(Student.getEmail());}
						   
						   else{ Clear_Control(); 
						         JOptionPane.showMessageDialog(null,"Record Not Found!!!", "Searching",JOptionPane.INFORMATION_MESSAGE);
								 txtIDnum.requestFocus();}
                      }} );

//-----------------------------------------Button Delete-------------------------------------------------------         
		  btnRemove.addActionListener ( new ActionListener()
                     {  public void actionPerformed(ActionEvent e)
                        {  Student.Delete(txtIDnum.getText()); 
						   Clear_Control(); 
						   txtIDnum.requestFocus();
                           JOptionPane.showMessageDialog(null,"Seleted Record is Already Removed!!!", "Deleting",JOptionPane.INFORMATION_MESSAGE);
                      }} );
					  
//------------------------------------------Button Close-------------------------------------------------------------------------------------------------					  
		 btnClose.addActionListener ( new ActionListener()
                     {  public void actionPerformed(ActionEvent e)
        			  { System.exit(0); }});
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------					  
		 this.addWindowListener( new WindowAdapter()
                                 { public void windowClosing(WindowEvent e)
                                         {System.exit(0); }  }    
                                 );
        }         
//-----------------------------------------Clear Control Value------------------------------------//------------------------------------------Button Close-------------------------------------------------------------------------------------------------					  -------------------         		 
     private void Clear_Control()
     {txtName.setText(""); 
	  CmbGender.setSelectedItem("");
	  CmbCivilStatus.setSelectedItem("");
	  txtEMail.setText(""); }		 


//---------------------------------------End Class----------------------------------------------------		
   } 