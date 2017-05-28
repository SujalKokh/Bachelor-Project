package np.edu.rms.meritpoints;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
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
 * Created by sujal on 7/21/2016.
 */
public class Add_student extends AppCompatActivity {
    EditText uname;
    EditText mail;
    EditText pwd;
    Button btn;
    protected void onPause() {
        super.onPause();
        finish();
    }
    String url = receivedata.ur + "add_student.php";
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_student);
        uname = (EditText) findViewById(R.id.username);
        mail = (EditText) findViewById(R.id.email);
        pwd = (EditText) findViewById(R.id.password);
        btn = (Button) findViewById(R.id.add);
        final String username = uname.getText().toString();
        final String email = mail.getText().toString();
        final String password = pwd.getText().toString();
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                StringRequest stringRequest=new StringRequest(Request.Method.POST, url, new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        Toast.makeText(Add_student.this, "Sucessful" + response.toString(), Toast.LENGTH_LONG).show();
                    }

                }, new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Toast.makeText(Add_student.this,error.toString(),Toast.LENGTH_LONG).show();
                    }
                }
                ){
                    @Override
                    protected Map<String, String> getParams() {
                        Map<String,String> parameters = new HashMap<String, String>();
                        parameters.put("username",username);
                        parameters.put("email",email);
                        parameters.put("password",password);
                        return parameters;
                    }

                };

                RequestQueue requestQueue= Volley.newRequestQueue(Add_student.this);
                requestQueue.add(stringRequest);
            }
        });
    }
}
