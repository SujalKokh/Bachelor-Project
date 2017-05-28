package np.edu.rms.meritpoints;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
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

public class Enter_meritpoint extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {
    @Override
    protected void onPause() {
        super.onPause();
        //finish();
    }
    final String url = receivedata.ur + "enter_meritpoint.php";
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_enter_meritpoint);

            setContentView(R.layout.activity_enter_meritpoint);
            EditText stdid;
            EditText pnt;
            EditText rmark;
            Button enter;
            stdid = (EditText) findViewById(R.id.student_id);
            pnt = (EditText) findViewById(R.id.point);
            rmark = (EditText) findViewById(R.id.remark);
            enter = (Button) findViewById(R.id.enter);
        final String std_id = stdid.getText().toString().trim();
        final String point= pnt.getText().toString().trim();
        final String remark= rmark.getText().toString().trim();

        enter.setOnClickListener(new View.OnClickListener() {
            final String teacher_id=login.teacher_id;
            final String subject_id=login.subject_id;

            @Override
            public void onClick(View v) {
                StringRequest stringRequest=new StringRequest(Request.Method.POST, url, new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        Toast.makeText(Enter_meritpoint.this, "Sucessful" + response.toString(), Toast.LENGTH_LONG).show();
                    }

                }, new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Toast.makeText(Enter_meritpoint.this,error.toString(),Toast.LENGTH_LONG).show();
                    }
                }
                ){
                    @Override
                    protected Map<String, String> getParams() {
                        Map<String,String> parameters = new HashMap<String, String>();
                        parameters.put("student_id",std_id);
                        parameters.put("point",point);
                        parameters.put("remark",remark);
                        parameters.put("teacher_id",teacher_id);
                        parameters.put("subject_id",subject_id);
                        if(subject_id=="1"){
                            parameters.put("subject_name","english");
                        }
                        else if(subject_id=="2"){
                            parameters.put("subject_name","nepali");
                        }
                        else if(subject_id=="3"){
                            parameters.put("subject_name","math");
                        }
                        else if(subject_id=="4"){
                            parameters.put("subject_name","science");
                        }
                        else if(subject_id=="5"){
                            parameters.put("subject_name","social");
                        }
                        else if(subject_id=="6"){
                            parameters.put("subject_name","hpe");
                        }
                        else if(subject_id=="7"){
                            parameters.put("subject_name","opt_math");
                        }
                        else if(subject_id=="8"){
                            parameters.put("subject_name","computer");
                        }
                        else if(subject_id=="9"){
                            parameters.put("subject_name","obt");
                        }
                        else if(subject_id=="10"){
                            parameters.put("subject_name","account");
                        }
                        return parameters;
                    }

                };

                RequestQueue requestQueue= Volley.newRequestQueue(Enter_meritpoint.this);
                requestQueue.add(stringRequest);
            }
        });

        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Welcome to RMS Merit Point system", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.setDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);
    }





    @Override
    public void onBackPressed(){
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.home_student, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();
        if(login.user_admin==1){
            if(id == R.id.nav_entermeritpoints){
                Intent intent = new Intent(Enter_meritpoint.this,Enter_meritpoint.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_addteacher) {
                Intent intent = new Intent(Enter_meritpoint.this,Add_teacher.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_addstudent) {
                Intent intent = new Intent(Enter_meritpoint.this,Add_student.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_removeteacher) {
                Intent intent = new Intent(Enter_meritpoint.this,Remove_teacher.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_removestudent) {
                Intent intent = new Intent(Enter_meritpoint.this,Remove_student.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_viewall) {

            }
            else if (id == R.id.nav_change_password) {
                Intent intent = new Intent(Enter_meritpoint.this,change_password_student.class);
                startActivity(intent);
                Toast.makeText(Enter_meritpoint.this, "change password", Toast.LENGTH_SHORT).show();
            }

            else if (id == R.id.nav_log_out) {
                android.os.Process.killProcess(android.os.Process.myPid());
                System.exit(1);
            }
        }
        else if(login.user_teacher==1){
            if (id == R.id.nav_entermeritpoints) {
                Intent intent = new Intent(Enter_meritpoint.this,Enter_meritpoint.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_change_password) {
                Intent intent = new Intent(Enter_meritpoint.this,change_password_student.class);
                startActivity(intent);
                Toast.makeText(Enter_meritpoint.this, "change password", Toast.LENGTH_SHORT).show();
            }
            else if (id == R.id.nav_log_out) {
                android.os.Process.killProcess(android.os.Process.myPid());
                System.exit(1);

            }

        }
        else if(login.user_student==1) {
            if (id == R.id.nav_change_password) {
                Intent intent = new Intent(Enter_meritpoint.this, change_password_student.class);
                startActivity(intent);
                Toast.makeText(Enter_meritpoint.this, "change password", Toast.LENGTH_SHORT).show();
            }
            else if (id == R.id.nav_log_out) {
                android.os.Process.killProcess(android.os.Process.myPid());
                System.exit(1);
            }
        }
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }
}
