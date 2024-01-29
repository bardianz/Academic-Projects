package com.example.tictactoe;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.app.AppCompatDelegate;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.Switch;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    int turn = 0;   // 0 = x    //  1 = o
    boolean gameContinue = true;


    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
//        setContentView(R.layout.end_game);

        TextView turnDisplay = findViewById(R.id.turnDisplay);
        turnDisplay.setText("Turn : X");


        Switch switchtheme = findViewById(R.id.switchtheme);
        switchtheme.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                // TODO Auto-generated method stub
                if (buttonView.isChecked()) {
                    AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);
                } else {
                    AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);
                }
            }
        });
    }


    public void btnReset(View view) {
            for (int j = 0; j <= 2; j++) {
                row0[j] = 10;
                row1[j] = 10;
                row2[j] = 10;
            }
        Button btn00 = findViewById(R.id.btn00);
        Button btn01 = findViewById(R.id.btn01);
        Button btn02 = findViewById(R.id.btn02);
        Button btn10 = findViewById(R.id.btn10);
        Button btn11 = findViewById(R.id.btn11);
        Button btn12 = findViewById(R.id.btn12);
        Button btn20 = findViewById(R.id.btn20);
        Button btn21 = findViewById(R.id.btn21);
        Button btn22 = findViewById(R.id.btn22);
        btn00.setText("");
        btn00.setClickable(true);
        btn01.setText("");
        btn01.setClickable(true);
        btn02.setText("");
        btn02.setClickable(true);
        btn10.setText("");
        btn10.setClickable(true);
        btn11.setText("");
        btn11.setClickable(true);
        btn12.setText("");
        btn12.setClickable(true);
        btn20.setText("");
        btn20.setClickable(true);
        btn21.setText("");
        btn21.setClickable(true);
        btn22.setText("");
        btn22.setClickable(true);
        if (turn == 1) {
            turnChanger();
        }
        gameContinue = true;
    }

    private void turnChanger() {
        TextView turnDisplay = findViewById(R.id.turnDisplay);
        if (turn == 0) {
            turn = 1;
            turnDisplay.setText("Turn : O");
        } else {
            turn = 0;
            turnDisplay.setText("Turn : X");
        }
    }

    private int getInt(String t, int index) {
        char temp = t.charAt(index);
        String str = temp + "";
        return Integer.parseInt(str);
    }

    public void btnClick(View view) {
        if (gameContinue) {
            Button clickedBtn = (Button) view;
            String tag = clickedBtn.getTag().toString();

            int i = getInt(tag, 0);
            int j = getInt(tag, 1);

            switch (i) {
                case 0:
                    row0[j] = turn;
                    break;
                case 1:
                    row1[j] = turn;

                    break;
                case 2:
                    row2[j] = turn;
                    break;
            }

            clickedBtn.setTranslationY(-1500);
            if (turn == 1) {
                clickedBtn.setText("O");
            } else {
                clickedBtn.setText("X");
            }
            clickedBtn.animate().translationYBy(1500).rotation(3600).setDuration(330);
            clickedBtn.setClickable(false);
            turnChanger();
            if (winnerChecker() != 10) {
                String result = "";
                if (winnerChecker() == 0) {
                    result = "winner is X";
                } else if (winnerChecker() == 1) {
                    result = "winner is o";
                } else if (winnerChecker() == 2) {
                    result = "Draw! reset the game";
                }
                TextView turnDisplay = findViewById(R.id.turnDisplay);
                turnDisplay.setText(result);
                Toast.makeText(this, result, Toast.LENGTH_SHORT).show();
            }
        }
    }

    int[] row0 = {10, 10, 10};
    int[] row1 = {10, 10, 10};
    int[] row2 = {10, 10, 10};

    private int winnerChecker() {
        for (int i = 0; i <= 2; i++) {
            if (row0[i] == 0 && row1[i] == 0 && row2[i] == 0) {
                gameContinue = false;
                return 0;
            }
            if (row0[i] == 1 && row1[i] == 1 && row2[i] == 1) {
                gameContinue = false;
                return 1;
            }
        }

        if (row0[0] == 0 && row0[1] == 0 && row0[2] == 0) {
            gameContinue = false;
            return 0;
        }
        if (row0[0] == 1 && row0[1] == 1 && row0[2] == 1) {
            gameContinue = false;
            return 1;
        }

        if (row1[0] == 0 && row1[1] == 0 && row1[2] == 0) {
            gameContinue = false;
            return 0;
        }
        if (row1[0] == 1 && row1[1] == 1 && row1[2] == 1) {
            gameContinue = false;
            return 1;
        }

        if (row2[0] == 0 && row2[1] == 0 && row2[2] == 0) {
            gameContinue = false;
            return 0;
        }
        if (row2[0] == 1 && row2[1] == 1 && row2[2] == 1) {
            gameContinue = false;
            return 1;
        }

        if (row0[0] == 0 && row1[1] == 0 && row2[2] == 0) {
            gameContinue = false;
            return 0;
        }
        if (row0[0] == 1 && row1[1] == 1 && row2[2] == 1) {
            gameContinue = false;
            return 1;
        }
        if (row0[2] == 0 & row1[1] == 0 && row2[0] == 0) {
            gameContinue = false;
            return 0;
        }
        if (row0[2] == 1 & row1[1] == 1 && row2[0] == 1) {
            gameContinue = false;
            return 1;
        }
        if (drawChecker()) {
            return 2;
        }
        gameContinue = true;
        return 10;
    }

    private boolean drawChecker() {
        for (int i = 0; i <= 2; i++) {
            if (row0[i] == 10)
                return false;
            else if (row1[i] == 10)
                return false;
            else if (row2[i] == 10)
                return false;
        }
        return true;
    }
}