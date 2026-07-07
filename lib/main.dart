import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Görev Yönetim Uygulaması',
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Giriş Yap'),
        ),
        body: Center(
          child: Column(
  mainAxisAlignment: MainAxisAlignment.center,
  children: [
    Text('Görev Yönetim Uygulamasına Hoş Geldiniz'),
    SizedBox(height: 20),
    TextField(
      SizedBox(height: 15),
      TextField(
  obscureText: true,
  decoration: InputDecoration(
    labelText: 'Şifre',
    border: OutlineInputBorder(),
  ),
),
  decoration: InputDecoration(
    labelText: 'E-posta',
    border: OutlineInputBorder(),
  ),
),
  ],
),'),
        ),
      ),
    );
  }
}
