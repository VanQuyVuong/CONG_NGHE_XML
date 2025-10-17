package com.example.baitap;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class SecondActivity extends AppCompatActivity {
    Button btnBack;
    TextView tvHienThi;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_second);
        btnBack = findViewById(R.id.btnBack);
        tvHienThi = findViewById(R.id.tvHienThi);

        Intent intent = getIntent();
        String ten = intent.getStringExtra("ten");
        String msv = intent.getStringExtra("msv");
tvHienThi.setText("ten:"+ten + "msv"+msv);
        btnBack.setOnClickListener(v -> finish());
    }
}
