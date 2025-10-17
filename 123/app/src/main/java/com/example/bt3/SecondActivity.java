package com.example.bt3;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class SecondActivity extends AppCompatActivity {
    Button btnBack, btnTinh;
    EditText edSo1, edSo2;
    TextView tvHienthi, tvUCLN;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        btnBack = findViewById(R.id.btnBack);
        btnTinh = findViewById(R.id.btnTinh);
        edSo1 = findViewById(R.id.edSo1);
        edSo2 = findViewById(R.id.edSo2);
        tvHienthi = findViewById(R.id.tvHienThi);
        tvUCLN = findViewById(R.id.tvUCLN);

        String ten = getIntent().getStringExtra("ten");
        String lop = getIntent().getStringExtra("lop");
        String msv = getIntent().getStringExtra("msv");

        tvHienthi.setText("\nTen :" + ten + "\nMa sinh vien :" + msv + "\nLop :" + lop);

        btnTinh.setOnClickListener(V -> {
            int a = Integer.parseInt(edSo1.getText().toString());
            int b = Integer.parseInt(edSo2.getText().toString());
            int ucln = findUCLN(a, b);
            tvUCLN.setText("UCLN của " + a + " và " + b + " là :" + ucln);
        });
        btnBack.setOnClickListener(v -> finish());
    }
        private int findUCLN(int a , int b){
            while (b != 0) {
                int tg = b;
                b = a % b;
                a = tg;

            }
            return a;
        }
    }
