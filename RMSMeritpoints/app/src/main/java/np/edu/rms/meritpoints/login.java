package np.edu.rms.meritpoints;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.android.volley.RequestQueue;


/**
 * Created by sujal on 6/17/2016.
 */


public class login extends AppCompatActivity {
    EditText ed_email, ed_password;
    @Override
    protected void onPause() {
        super.onPause();
        finish();
    }
    public static int user_admin;
    public static int user_teacher;
    public static int user_student;
    public static String teacher_id;
    public static String subject_id;
    public static String std_id;


    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        new receivedata(login.this);
        new ReceiveDataFromLoginStudent(login.this);
        ed_email = (EditText) findViewById(R.id.email);
        ed_password = (EditText) findViewById(R.id.password);
        Button btn_login = (Button) findViewById(R.id.btn_login);

        //to clear the text present in EditText
        ed_email.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ed_email.setText("");
            }
        });
        ed_password.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ed_password.setText("");
            }
        });

        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //checking for admin login
                if(ed_email.getText().toString().equals("admin") && ed_password.getText().toString().equals("admin")){
                    Intent intent = new Intent(login.this, Enter_meritpoint.class);
                    startActivity(intent);
                    Toast.makeText(login.this, "Sucessfully Logged In", Toast.LENGTH_LONG).show();
                    user_admin=1;
                }
                else{
                    // check login for teacher
                      checkValidity();
                    //check login for students

                }

            }
        });
    }

    private void checkValidity(){
        Log.d("Inside the login","Login");
        final String entered_email = ed_email.getText().toString();
        final String entered_password = ed_password.getText().toString();
        int i=0,j=0,k=0;
        for(i=0;i<receivedata.arrayList.size();i++){
            if((entered_email.equals(receivedata.arrayList.get(i).getEmail())) && (entered_password.equals(receivedata.arrayList.get(i).getPassword()))){
                Intent intent = new Intent(login.this, Enter_meritpoint.class);
                startActivity(intent);
                user_teacher=1;
                teacher_id = receivedata.arrayList.get(i).getTeacher_id().toString();
                subject_id = receivedata.arrayList.get(i).getSubject_id().toString();
                Toast.makeText(login.this, "Sucessfully Logged In as Teacher", Toast.LENGTH_LONG).show();
                j=j+1;
            }
        }
       if(j==0){
            i=0;
            j=0;
            k=0;
            for(i=0;i<ReceiveDataFromLoginStudent.arrayList.size();i++){
                if((entered_email.equals(ReceiveDataFromLoginStudent.arrayList.get(i).getEmail())) && (entered_password.equals(ReceiveDataFromLoginStudent.arrayList.get(i).getPassword()))){
                    std_id = ReceiveDataFromLoginStudent.arrayList.get(i).getStudent_id();
                    Intent intent = new Intent(login.this, home_student.class);
                    startActivity(intent);
                    user_student=1;
                    Toast.makeText(login.this, "Sucessfully Logged In as student", Toast.LENGTH_LONG).show();
                    k=k+1;
                }
            }
        } if(k==0){Toast.makeText(login.this, "Invalid Useraname/Password", Toast.LENGTH_LONG).show();}}

}
