package com.example.sherepref;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MainActivity extends AppCompatActivity {

    private static final String PREFS_FILE = "Account";
    private static final String PREF_NAME = "Name";
    private static final String PREF_password = "pass";
    private static final String PREF_mail = "mail";


    Button nextWindow;
    SharedPreferences settings;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        settings = getSharedPreferences(PREFS_FILE, MODE_PRIVATE);
    }

    public void saveName(View view) {
        // получаем введенное имя
        EditText nameBox = findViewById(R.id.nameBox);
        String name = nameBox.getText().toString();
        // сохраняем его в настройках
        SharedPreferences.Editor prefEditor = settings.edit();
        prefEditor.putString(PREF_NAME, name);
        prefEditor.apply();


        // получаем введенное password
        EditText pass_box = findViewById(R.id.password);
        String password = pass_box.getText().toString();
        // сохраняем его в настройках
        prefEditor.putString(PREF_password, password);
        prefEditor.apply();

        // получаем введенное mail
        EditText mail_box = findViewById(R.id.Mail);
        String mail = mail_box.getText().toString();
        // сохраняем его в настройках
        prefEditor.putString(PREF_mail, mail);
        prefEditor.apply();

        if(name.isEmpty() || password.isEmpty() || mail.isEmpty())
        {
            Toast.makeText(MainActivity.this , "Заполните все поля", Toast.LENGTH_SHORT).show();
            return;
        }
        else
        {
            nextWindow = findViewById(R.id.saveButton);
            nextWindow.setOnClickListener(v -> {
                Intent intent = new Intent(MainActivity.this , page3.class);
                startActivity(intent);
            });
            Toast.makeText(MainActivity.this , "Добро пожаловать в аккаунт", Toast.LENGTH_SHORT).show();
        }


    }


}