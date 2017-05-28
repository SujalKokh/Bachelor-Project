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
public class receivedata {
    public static String ur = "http://192.168.123.12/mp/";
    public static String url = ur + "check_signin.php";
    public static ArrayList<profile> arrayList;
    public static String teacher_id, username, email, password, subject_id;
    public static int id;
    private ProgressDialog loading;
    int i = 0;

    receivedata(final Context context) {
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
                                teacher_id = info.getString("teacher_id");
                                username = info.getString("username");
                                email = info.getString("email");
                                password = info.getString("password");
                                subject_id = info.getString("subject_id");
                                arrayList.add(new profile(teacher_id, username, email, password, subject_id));
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
        private String teacher_id;
        private String username;
        private String email;
        private String password;
        private String subject_id;

        public profile(String teacher_id, String username, String email, String password, String subject_id) {
            Log.d("Tag", "enter in profile");
            this.teacher_id = teacher_id;
            this.username = username;
            this.email = email;
            this.password = password;
            this.subject_id = subject_id;
        }

        public String getTeacher_id() {
            return teacher_id;
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

        public String getSubject_id() {
            return subject_id;
        }
    }
}






