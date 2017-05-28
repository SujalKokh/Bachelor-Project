package np.edu.rms.meritpoints;

import android.app.ProgressDialog;
import android.content.Context;
import android.util.Log;

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
 * Created by sujal on 7/23/2016.
 */
public class GetMeritPoint {
    public static String url = receivedata.ur + "meritpoint.php";
    public static ArrayList<profile> arrayList;
    public static String student_id, english, nepali, math, science, social, hpe, opt_math, computer, obt, account;
    private ProgressDialog loading;

    GetMeritPoint (final Context context) {
        arrayList = new ArrayList<profile>();
        loading = ProgressDialog.show(context,"Please wait... ","Fetching...",false,false);
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
                                english = info.getString("english");
                                nepali = info.getString("nepali");
                                math = info.getString("math");
                                science = info.getString("science");
                                social = info.getString("social");
                                hpe = info.getString("hpe");
                                opt_math = info.getString("opt_math");
                                computer = info.getString("computer");
                                obt = info.getString("obt");
                                account = info.getString("account");
                                arrayList.add(new profile(student_id, english, nepali, math, science, social, hpe, opt_math, computer, obt, account));
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

    public class profile{
        private String student_id;
        private String english;
        private String nepali;
        private String math;
        private String science;
        private String social;
        private String hpe;
        private String opt_math;
        private String computer;
        private String obt;
        private String account;

        public profile(String student_id, String english, String nepali, String math, String science, String social, String hpe, String opt_math, String computer, String obt, String account) {
            Log.d("Tag","Into the profile class");
            this.student_id = student_id;
            this.english = english;
            this.nepali = nepali;
            this.math = math;
            this.science = science;
            this.social = social;
            this.hpe = hpe;
            this.opt_math = opt_math;
            this.computer = computer;
            this.obt= obt;
            this.account = account;
        }

        public String getStudent_id(){return student_id;}
        public String getEnglish(){return english;}
        public String getNepali(){return nepali;}
        public String getMath(){return math;}
        public String getScience(){return science;}
        public String getSocial(){return social;}
        public String getHpe(){return hpe;}
        public String getOpt_math(){return opt_math;}
        public String getComputer(){return computer;}
        public String getObt(){return obt;}
        public String getAccount(){return account;}
    }
}
