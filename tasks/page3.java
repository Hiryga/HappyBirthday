package com.example.sherepref;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class page3 extends AppCompatActivity {

    TextView nameView;
    TextView passView;
    TextView mailView;


    private static final String PREFS_FILE = "Account";
    private static final String PREF_NAME = "Name";
    private static final String PREF_password = "pass";
    private static final String PREF_mail = "mail";
    SharedPreferences settings;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_page3);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);

            return insets;
        });
        nameView = findViewById(R.id.textView2);
        passView = findViewById(R.id.textView4);
        mailView = findViewById(R.id.textView5);
        settings = getSharedPreferences(PREFS_FILE, MODE_PRIVATE);

        getName();
    }

    public void getName() {
        // получаем сохраненное имя
        String name = settings.getString(PREF_NAME,"Фио - не определено");
        nameView.setText(name);
        String password = settings.getString(PREF_password,"password - не определён");
        passView.setText(password);
        String mail = settings.getString(PREF_mail,"Mail - Не определён");
        mailView.setText(mail);
    }
}