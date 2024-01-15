package ir.notroweb.ageapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.util.Calendar;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
//        Button btnCalculate = findViewById(R.id.btnCalculate);

        TextView txtviewResult = findViewById(R.id.txtviewResult);


        Button button = findViewById(R.id.btnCalculate);

        button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                getValue();
                if (validate()==true && VALIDATE==true) {
                    txtviewResult.setText(calculate());
                    txtviewResult.setVisibility(View.VISIBLE);
                    showDetail();
                } else {
                    txtviewResult.setVisibility(View.INVISIBLE);
                }
            }
        });
    }

    int year, month, day;
    Boolean VALIDATE;

    public void showDetail() {
        int dayDetail= day + month*30 + year*365;
        int monthDetail = month + year*12 ;
        int weekDetail = monthDetail* 4;
        int hourDetail = dayDetail*24;
        TextView txtviewResultDay = findViewById(R.id.txtviewResultDay);
        TextView txtviewResultMonth = findViewById(R.id.txtviewResultMonth);
        TextView txtviewResultWeek = findViewById(R.id.txtviewResultWeek);
        TextView txtviewResultHour = findViewById(R.id.txtviewResultHour);

        txtviewResultDay.setText(dayDetail +" Days");
        txtviewResultMonth.setText(monthDetail +" Months");
        txtviewResultWeek.setText(weekDetail +" Weeks");
        txtviewResultHour.setText(hourDetail +" Hours");

        txtviewResultDay.setVisibility(View.VISIBLE);
        txtviewResultMonth.setVisibility(View.VISIBLE);
        txtviewResultWeek.setVisibility(View.VISIBLE);
        txtviewResultHour.setVisibility(View.VISIBLE);
    }
    public void getValue() {
        TextView txtviewResult = findViewById(R.id.txtviewResult);
        EditText editTextDay = findViewById(R.id.editTextDay);
        EditText editTextMonth = findViewById(R.id.editTextMonth);
        EditText editTextYear = findViewById(R.id.editTextYear);
        try {
            txtviewResult.setVisibility(View.INVISIBLE);

            year = Integer.parseInt(editTextYear.getText().toString());
            month = Integer.parseInt(editTextMonth.getText().toString());
            day = Integer.parseInt(editTextDay.getText().toString());
            VALIDATE=true;
        }
        catch (Exception exception){
            txtviewResult.setVisibility(View.VISIBLE);
            txtviewResult.setText("WRONG INPUT");
            VALIDATE=false;
        }

    }

    public Boolean validate() {
        if (day > 31) return false;
        if (month > 12) return false;
        if (month > 6) {
            if (day > 30) return false;
        }
        return true;
    }

    public String calculate() {
        String DAY = dayCalculator() + " Day ";
        String MONTH = monthCalculator() + " Month ";
        String YEAR = yearCalculator() + " Year ";

        return YEAR + MONTH + DAY;
    }

    public int dayCalculator() {
        int currentDay = Calendar.getInstance().get(Calendar.DAY_OF_MONTH);
        if (currentDay - day >= 0) {
            return currentDay - day;
        } else {
            int resultDay;
            if (month <= 6) {
                resultDay = (31 - day) + currentDay;
            } else {
                resultDay = (30 - day) + currentDay;
            }
            month--;
            return resultDay;
        }
    }


    public int monthCalculator() {
        int currentMonth = Calendar.getInstance().get(Calendar.MONTH);
        if (currentMonth - month >= 0) {
            return currentMonth - month;
        } else {
            year--;
            return (12 - month) + currentMonth;
        }
    }

    public int yearCalculator() {
        int currentDate = Calendar.getInstance().get(Calendar.YEAR);
        return currentDate - year;
    }


}