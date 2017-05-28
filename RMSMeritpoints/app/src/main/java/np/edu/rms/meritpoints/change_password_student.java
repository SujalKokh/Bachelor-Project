package np.edu.rms.meritpoints;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

/**
 * Created by sujal on 6/18/2016.
 */

public class change_password_student extends AppCompatActivity {
    @Override
    protected void onPause() {
        super.onPause();
        finish();
    }

    @Override

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_change_password_student);
        Button btn = (Button) findViewById(R.id.btn_change_password);

       /* final EditText mail = (EditText) findViewById(R.id.email);
        final EditText password = (EditText) findViewById(R.id.password);
        final EditText cpassword = (EditText) findViewById(R.id.confirmpassword);

        mail.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                mail.setText("");
            }
        });

        password.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                password.setText("");
            }
        });

        cpassword.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                cpassword.setText("");
            }
        });*/



        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(change_password_student.this, "Password sucessfully changed", Toast.LENGTH_LONG).show();
                Intent fuck = new Intent(change_password_student.this, home_student.class);
                startActivity(fuck);
            }
        });
    }
}
