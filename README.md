# Kopya Finder

Bu proje, alt alta yazılı birçok yazıdan tekrar edenleri bulur ve sadece bir örneğini bırakır. Sonuçta oluşan listeyi panoya kopyalar. Örneğin:

1.255.255.254
2.255.255.254
4.255.255.254
8.255.255.254
10.255.255.254
1.255.255.254
7.255.255.254

şeklinde olan listedeki tekrar eden ögeleri çıkararak (bu liste için bu değer/değerler 1.255.255.254) aşağıdaki listeyi panoya kopyalar:

1.255.255.254
2.255.255.254
4.255.255.254
8.255.255.254
10.255.255.254
7.255.255.254

## Kullanım

Açılan uygulamadaki textboxa panonuzdaki veriyi yapıştırın ardından 'Check' butonuna basın.

### Derlenmiş Uygulama

Uygulamayı çalıştırmak için [Kopya Finder](Kopya%20finder/bin/Debug/net6.0-windows/Kopya%20finder.exe) dosyasını kullanabilirsiniz.

### Kaynak Kod

Eğer uygulamanın güvenilirliğinden şüphe ediyorsanız, projeyi [Visual Studio](https://visualstudio.microsoft.com/) ile açıp build edebilirsiniz.

## Gereksinimler

- .NET 6.0 veya üzeri
- Visual Studio (Geliştirici ortamı için önerilir)

## Kurulum

1. Depoyu klonlamak için aşağıdaki komutu kullanın:
    ```bash
    git clone https://github.com/emi-ran/Kopya-finder.git
    ```
2. Projeyi Visual Studio veya .NET CLI ile açın ve derleyin.
3. Derlenmiş uygulamayı çalıştırın.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için [Lisans Dosyasına](LICENSE) bakabilirsiniz.
