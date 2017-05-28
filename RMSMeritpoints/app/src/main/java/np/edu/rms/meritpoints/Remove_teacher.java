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
public class Remove_teacher extends AppCompatActivity {
    EditText uname;
    EditText mail;
    Button rem;
    String url =receivedata.ur+"remove_teacher.php";
    protected void onPause() {
        super.onPause();
        finish();
    }
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_remove_teacher);
        uname = (EditText) findViewById(R.id.username);
        mail = (EditText) findViewById(R.id.email);
        rem = (Button) findViewById(R.id.remove);
        final String username = uname.getText().toString();
        //final String email = mail.getText().toString().trim();
        rem.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                StringRequest stringRequest=new StringRequest(Request.Method.POST, url, new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        Toast.makeText(Remove_teacher.this, "Sucessful" + response.toString(), Toast.LENGTH_LONG).show();
                    }

                }, new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Toast.makeText(Remove_teacher.this,error.toString(),Toast.LENGTH_LONG).show();
                    }
                }
                ){
                    @Override
                    protected Map<String, String> getParams() {
                        Map<String,String> parameters = new HashMap<String, String>();
                        parameters.put("username",username);
                        return parameters;
                    }

                };
                RequestQueue requestQueue= Volley.newRequestQueue(Remove_teacher.this);
                requestQueue.add(stringRequest);

            }
        });
    }
}
