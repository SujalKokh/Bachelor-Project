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
import android.widget.TextView;
import android.widget.Toast;

public class home_student extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {
    @Override
    protected void onPause() {
        super.onPause();
        //finish();
    }
    TextView eng;
    TextView nep;
    TextView mat;
    TextView sci;
    TextView soc;
    TextView hpe;
    TextView opt;
    TextView com;
    TextView obt;
    TextView acc;
    String ur=receivedata.ur+"meritpoint.php";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        setContentView(R.layout.activity_home_student);
        super.onCreate(savedInstanceState);

        eng = (TextView) findViewById(R.id.token_english);
        nep = (TextView) findViewById(R.id.token_nepali);
        mat = (TextView) findViewById(R.id.token_math);
        sci = (TextView) findViewById(R.id.token_science);
        soc = (TextView) findViewById(R.id.token_social);
        hpe = (TextView) findViewById(R.id.token_hpe);
        opt = (TextView) findViewById(R.id.token_optmath);
        com = (TextView) findViewById(R.id.token_computer);
        obt = (TextView) findViewById(R.id.token_obt);
        acc = (TextView) findViewById(R.id.token_account);

        new GetMeritPoint(home_student.this);
        String s_id = login.std_id;

        for(int i=0;i<GetMeritPoint.arrayList.size();i++){
            String temp_sid = GetMeritPoint.arrayList.get(i).getStudent_id();
            if(s_id == temp_sid ){
                eng.setText(GetMeritPoint.arrayList.get(i).getEnglish());
                nep.setText(GetMeritPoint.arrayList.get(i).getNepali());
                mat.setText(GetMeritPoint.arrayList.get(i).getMath());
                sci.setText(GetMeritPoint.arrayList.get(i).getScience());
                soc.setText(GetMeritPoint.arrayList.get(i).getSocial());
                hpe.setText(GetMeritPoint.arrayList.get(i).getHpe());
                opt.setText(GetMeritPoint.arrayList.get(i).getOpt_math());
                com.setText(GetMeritPoint.arrayList.get(i).getComputer());
                obt.setText(GetMeritPoint.arrayList.get(i).getObt());
                acc.setText(GetMeritPoint.arrayList.get(i).getAccount());
            }
        }
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
    public void onBackPressed() {
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
            if (id == R.id.nav_entermeritpoints) {
                Intent intent = new Intent(home_student.this,Enter_meritpoint.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_addteacher) {
                Intent intent = new Intent(home_student.this,Add_teacher.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_addstudent) {
                Intent intent = new Intent(home_student.this,Add_student.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_removeteacher) {
                Intent intent = new Intent(home_student.this,Remove_teacher.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_removestudent) {
                Intent intent = new Intent(home_student.this,Remove_student.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_viewall) {

            }
            else if (id == R.id.nav_change_password) {
                Intent intent = new Intent(home_student.this,change_password_student.class);
                startActivity(intent);
                Toast.makeText(home_student.this, "change password", Toast.LENGTH_SHORT).show();
            }

            else if (id == R.id.nav_log_out) {
                android.os.Process.killProcess(android.os.Process.myPid());
                System.exit(1);
            }
        }
        else if(login.user_teacher==1){
            if (id == R.id.nav_entermeritpoints) {
                Intent intent = new Intent(home_student.this,Enter_meritpoint.class);
                startActivity(intent);
            }
            else if (id == R.id.nav_change_password) {
                    Intent intent = new Intent(home_student.this,change_password_student.class);
                    startActivity(intent);
                    Toast.makeText(home_student.this, "change password", Toast.LENGTH_SHORT).show();
                }
                else if (id == R.id.nav_log_out) {
                android.os.Process.killProcess(android.os.Process.myPid());
                System.exit(1);
            }

        }
        else if(login.user_student==1) {
            if (id == R.id.nav_change_password) {
                Intent intent = new Intent(home_student.this, change_password_student.class);
                startActivity(intent);
                Toast.makeText(home_student.this, "change password", Toast.LENGTH_SHORT).show();
            } else if (id == R.id.nav_log_out) {
                android.os.Process.killProcess(android.os.Process.myPid());
                System.exit(1);
            }
        }
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }
}
