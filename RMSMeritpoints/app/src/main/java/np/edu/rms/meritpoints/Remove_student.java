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
public class Remove_student extends AppCompatActivity {
    EditText uname;
    protected void onPause() {
        super.onPause();
        finish();
    }
    String url = receivedata.ur + "a.php";
    protected void onCreate(Bundle savedInstanceState) {


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_remove_student);
        Button button;
        button=(Button)findViewById(R.id.remove);
        uname = (EditText)findViewById(R.id.username);
        final String username = uname.getText().toString().trim();
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                StringRequest stringRequest=new StringRequest(Request.Method.POST, url, new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        Toast.makeText(Remove_student.this, "Sucessful" + response.toString(), Toast.LENGTH_LONG).show();
                    }

                }, new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Toast.makeText(Remove_student.this,error.toString(),Toast.LENGTH_LONG).show();
                    }
                }
                ){
                    @Override
                    protected Map<String, String> getParams() {
                        Map<String,String> parameters = new HashMap<String, String>();
                        parameters.put("name",username);
                        return parameters;
                    }

                };

                RequestQueue requestQueue= Volley.newRequestQueue(Remove_student.this);
                requestQueue.add(stringRequest);
            }
        });

    }
}
