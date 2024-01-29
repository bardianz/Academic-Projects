package com.example.heisenberg;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void enterName(View view) {
        EditText inp = (EditText) findViewById(R.id.inputText);
        ImageView fview = (ImageView) findViewById(R.id.firstImage);
        ImageView sview = (ImageView) findViewById(R.id.secondImage);
        try {
            String txt = inp.getText().toString().toLowerCase();
            System.out.println(txt);
            if (txt.equals("heisenberg")) {
                try {
                    InputMethodManager imm = (InputMethodManager) getSystemService(INPUT_METHOD_SERVICE);
                    imm.hideSoftInputFromWindow(getCurrentFocus().getWindowToken(), 0);
                } catch (Exception ex) {
                    String err = ex.getMessage();
                }
                Toast.makeText(this, "You're God damn right. ", Toast.LENGTH_SHORT).show();
                fview.animate().alpha(0).setDuration(2000);
                sview.animate().alpha(1).setDuration(2000);
            }
            else if (txt.equals("")) {
                Toast.makeText(this, "type something!\ndo not be afraid :)", Toast.LENGTH_LONG).show();

            }

            else {
                fview.animate().alpha(1).setDuration(500);
                sview.animate().alpha(0).setDuration(500);
                Toast.makeText(this, "no!", Toast.LENGTH_SHORT).show();
            }
        } catch (Exception ex) {
            String err = ex.getMessage();
            Toast.makeText(this, "Bad input or something...\n" + err, Toast.LENGTH_LONG).show();
        } finally {
            inp.setText("");
        }

    }
}