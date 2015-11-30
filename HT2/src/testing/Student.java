package testing;

import java.io.*;

public class Student
{ private static String Delimeter="|";
  private static String IDNumber,Name, Gender,CivilStatus,Email;
  private static String[] StudentProfile= new String[6];
  private static String[] myIDNumber= new String[1];
  private static String FoundRecord ="";
  private static String DataFile ="";
  private static String thisLine ="";
  private static String SelectedRecord="";
  public static boolean isRecordFound=false;
  
  Student(String TxtFile){DataFile=TxtFile;}
   
  public static void setIDNumber(String newValue) {IDNumber=newValue;}
  public static String getIDNumber() {return IDNumber;}
  
  public static void setName(String newValue) {Name=newValue;}
  public static String getName() {return Name;}
  
  public static void setGender(String newValue) {Gender=newValue;}
  public static String getGender() {return Gender;}
  
  public static void setCivilStatus(String newValue) {CivilStatus=newValue;}
  public static String getCivilStatus() {return CivilStatus;}
  
  public static void setEmail(String newValue) {Email=newValue;}
  public static String getEmail() {return Email;}
  
  private static String StudentRecord()
     {return IDNumber+Delimeter+Name+Delimeter+Gender+Delimeter+CivilStatus+Delimeter+Email;}

 //=========================Generate ID Number========================
  @SuppressWarnings("deprecation")
public static String GetNew_IDNumber() 
       { String MyIDNum="0";  
	     try{ FileInputStream Files = new FileInputStream(DataFile);
                DataInputStream myInput = new DataInputStream(Files);
                   while ((thisLine = myInput.readLine()) != null)
                           {myIDNumber= thisLine.split(Delimeter);
                             if (Integer.parseInt(myIDNumber[0])>Integer.parseInt(MyIDNum))
                                 { MyIDNum= myIDNumber[0];}                              
                           }
                         myInput.close();
		     }  
        catch (IOException ex){}
        int IDNum= Integer.parseInt(MyIDNum) + 1;
        return String.valueOf(IDNum);	
       }

 //=======================Save Record===========================================
  public static void AddNew() 
    {  if (Integer.parseInt(getIDNumber())>=1)
	    {Delete(getIDNumber());                 
	     Save_TextFile(DataFile,StudentRecord());}  
	}
  
 //------------------------------------------------------------------------------  
  private static void Save_TextFile(String vFileName,String newValue)
       {try{ FileWriter writeFile = new FileWriter(vFileName,true);
             PrintWriter myOutput= new PrintWriter(writeFile);
             myOutput.printf("%s" + "%n", newValue);
             myOutput.close(); }
        catch (IOException ex){}
		}
 //=========================Search Record Using ID Number========================
  
@SuppressWarnings("deprecation")
public static void Search_IDNumber(String SearchKey) 
       { isRecordFound=false;
	     try{ FileInputStream FileRec = new FileInputStream(DataFile);
              DataInputStream myInput = new DataInputStream(FileRec);
                   while ((thisLine = myInput.readLine()) != null)
                            { myIDNumber= thisLine.split(Delimeter);
                              if (Integer.parseInt(myIDNumber[0])==Integer.parseInt(SearchKey))
                                  { FoundRecord= thisLine;  isRecordFound=true;}                              
                             }
                         myInput.close();
			       if (FoundRecord!="") {Load_Record(FoundRecord);}
             }
            catch (IOException ex){}
       }
 //-----------------------------------------------------------------------------------------      
  private static void Load_Record(String newValue)
     { StudentProfile=newValue.split(Delimeter);
	    setIDNumber(StudentProfile[0]);
	    setName(StudentProfile[1]);
	    setGender(StudentProfile[2]);
	    setCivilStatus(StudentProfile[3]);
	    setEmail(StudentProfile[4]);
	 }

//=========================Delete Record Using ID Number========================
  @SuppressWarnings("deprecation")
public static void Delete(String SearchKey) 
       { try {FileInputStream Files = new FileInputStream(DataFile);
              DataInputStream myInput = new DataInputStream(Files);
                   while ((thisLine = myInput.readLine()) != null)
                           {myIDNumber= thisLine.split(Delimeter);
                                   SelectedRecord= thisLine;
                                if (Integer.parseInt(myIDNumber[0])!=Integer.parseInt(SearchKey))
                                      { Save_TextFile("TempData.txt",SelectedRecord);}                                  
                             }
                         myInput.close();
                         File OrigFile = new File(DataFile); 
                         OrigFile.delete(); 
                         File TempFile = new File("TempData.txt"); 
                         TempFile.renameTo(new File(DataFile)); 
           }
      
      catch (IOException ex){}
                     
       }
}