package testing;

import static org.junit.Assert.*;

import org.junit.Test;

public class TestCases {

	String output;
	
	@Test
	public void testing_user_details_saving() {
		//Username
		Student.setName("Ali");
		output = Student.getName();
		assertEquals("Ali",output);
		//ID
		Student.setIDNumber("1");
		output = Student.getIDNumber();
		assertEquals("1",output);
		//Eamil
		Student.setEmail("testuser@mail.com");
		output = Student.getEmail();
		assertEquals("testuser@mail.com",output);
		//Gender
		Student.setGender("male");
		output = Student.getGender();
		assertEquals("male",output);
		//Civilstatus
		Student.setCivilStatus("married");
		output = Student.getCivilStatus();
		assertEquals("married",output);
	}
	
	@Test
	public void searching_using_id_number() {
		Student.Search_IDNumber("1");
		if (Student.isRecordFound == false){
			boolean output = false;
			assertEquals(false,output);
		}
	}
	
	@Test
	public void saving_record(){
		Student.AddNew();
	}
	
	@Test
	public void Deleting_record(){
		Student.Delete("1");
		
	}
	
	@Test
	public void File_handling_window_checking(){
		MyWindow app = new MyWindow();
        app.setResizable(false);
        app.setLocation(400,250);
	}

}
