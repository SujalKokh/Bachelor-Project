package np.edu.rms.meritpoints;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.util.HashMap;
import java.util.Map;

/**
 * Created by sujal on 7/20/2016.
 */
public class Add_teacher extends AppCompatActivity {
    protected void onPause() {
        super.onPause();
        finish();
    }
    String url = receivedata.ur+"add_teacher.php";
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_teacher);
        EditText xname;
        EditText xusername;
        EditText xemail;
        EditText xpassword;
        EditText xsubject;
        Button btn;
        xname = (EditText) findViewById(R.id.name);
        xusername = (EditText) findViewById(R.id.username);
        xemail = (EditText) findViewById(R.id.email);
        xpassword = (EditText) findViewById(R.id.password);
        xsubject = (EditText) findViewById(R.id.subject);
        btn = (Button) findViewById(R.id.add);
        final String name=xname.getText().toString().trim();
        final String username=xusername.getText().toString().trim();
        final String email=xemail.getText().toString().trim();;
        final String password=xpassword.getText().toString().trim();
        final String subject=xsubject.getText().toString().trim();
        btn.setOnClickListener(new View.OnClickListener(){ public void onClick(View v) {
            StringRequest stringRequest=new StringRequest(Request.Method.POST, url, new Response.Listener<String>() {
                @Override
                public void onResponse(String response) {
                    Toast.makeText(Add_teacher.this, "Sucessful" + response.toString(), Toast.LENGTH_LONG).show();
                }

            }, new Response.ErrorListener() {
                @Override
                public void onErrorResponse(VolleyError error) {
                    Toast.makeText(Add_teacher.this,error.toString(),Toast.LENGTH_LONG).show();
                }
            }
            ){
                @Override
                protected Map<String, String> getParams() {
                    Map<String,String> parameters = new HashMap<String, String>();
                    parameters.put("name",name);
                    parameters.put("username",username);
                    parameters.put("email",email);
                    parameters.put("password",password);
                    parameters.put("subject_id",subject);
                    return parameters;
                }

            };

            RequestQueue requestQueue= Volley.newRequestQueue(Add_teacher.this);
            requestQueue.add(stringRequest);
        }
        });

    }
}


