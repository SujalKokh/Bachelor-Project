package np.edu.rms.meritpoints;

import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Context;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

/**
 * Created by sujal on 6/25/2016.
 */
public class ReceiveDataFromLoginStudent {
    public static String url = receivedata.ur + "login_student.php";
    public static ArrayList<profile> arrayList;
    public static String student_id, username, email, password;
    public static int id;
    private ProgressDialog loading;
    int i = 0;

    ReceiveDataFromLoginStudent(final Context context) {
        arrayList = new ArrayList<profile>();
        loading = ProgressDialog.show(context, "Please wait...", "Fetching...", false, false);

        JsonObjectRequest jsonObjreq = new JsonObjectRequest(
                Request.Method.GET, url, null,
                new Response.Listener<JSONObject>(){

                    @Override
                    public void onResponse(JSONObject response) {
                        // TODO Auto-generated method stub

                        try {
                            JSONArray data = response.getJSONArray("Data");

                            for (int i = 0; i < data.length(); i++) {
                                JSONObject info = data.getJSONObject(i);
                                student_id = info.getString("student_id");
                                username = info.getString("username");
                                email = info.getString("email");
                                password = info.getString("password");
                                arrayList.add(new profile(student_id, username, email, password));
                            }
                           loading.dismiss();
                        } catch (JSONException e) {
                            Log.d("Tag", e.toString());
                        }
                    }

                }, new Response.ErrorListener() {

            @Override
            public void onErrorResponse(VolleyError error) {
                // TODO Auto-generated method stub
                System.out.print(error.toString());
                Log.d("TAG", error.toString());
            }
        });
        RequestQueue requestQueue = Volley.newRequestQueue(context);
        requestQueue.add(jsonObjreq);
    }

    public class profile {

        private String student_id;
        private String username;
        private String email;
        private String password;


        public profile(String student_id, String username, String email, String password) {
            Log.d("Tag", "enter in profile");
            this.student_id = student_id;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public String getStudent_id() {
            return student_id;
        }

        public String getUsername() {
            return username;
        }

        public String getEmail() {
            return email;
        }

        public String getPassword() {
            return password;
        }

    }
}






