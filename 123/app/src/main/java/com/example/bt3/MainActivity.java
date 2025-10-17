package com.example.bt3;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
Button btnGo;
EditText edvTen , edvLop, edvMsv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_main);
        btnGo = findViewById(R.id.btnGo);
        edvTen = findViewById(R.id.edvTen);
        edvMsv = findViewById(R.id.edvMsv);
        edvLop = findViewById(R.id.edvLop);

        btnGo.setOnClickListener(v-> {

                String ten = edvTen.getText().toString();
                String lop = edvLop.getText().toString();
                String msv = edvMsv.getText().toString();

                Intent intent = new Intent(MainActivity.this , SecondActivity.class);
                intent.putExtra("ten", ten );
                intent.putExtra("lop", lop);
                intent.putExtra("msv", msv);

                startActivity(intent);

        });
    }
}