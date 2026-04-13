package com.example.testpushdata;

import android.content.Intent;
import android.os.Bundle;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        Button next = findViewById(R.id.nextBtn);
        TextView pasteTxt = findViewById(R.id.textView);
        EditText copyTxt = findViewById(R.id.editText);


        WebView browser=findViewById(R.id.webBrowser);
        browser.loadUrl("https://metanit.com");

        next.setOnClickListener(view -> {

          String txt = copyTxt.getText().toString();
          pasteTxt.setText(txt);


            Intent intent = new Intent(this, MainActivity2.class);
            intent.putExtra("name", txt);
            startActivity(intent);
            Toast.makeText(this,"Привет", Toast.LENGTH_SHORT).show();

        });



    }
}