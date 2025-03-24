![image](https://github.com/user-attachments/assets/f1e0811d-1620-46ff-a561-d02f3e495ef1)




Google Maps to WhatsApp Projesi
Bu proje, Google Maps API ve WhatsApp API entegrasyonu kullanarak, bir kullanıcıya yakın yerleri bulmayı ve bu bilgileri WhatsApp üzerinden paylaşmayı amaçlayan bir uygulama sunmaktadır. Aşağıda, projenin işleyişine dair önemli bir kısmı bulacaksınız.

Kullanılan Teknolojiler:
Google Places API: Yerleri aramak için kullanılır.

WhatsApp API: Bulunan yerlerin bilgilerini WhatsApp üzerinden paylaşmak için kullanılır.

Kod Açıklaması:
Aşağıdaki sabitler, Google Maps API ile yapılacak aramalar için gerekli olan API anahtarını ve API'ye istek göndereceğimiz URL'yi içerir:


private const string GoogleApiKey = "API_KEY";  // Burada, Google Maps API anahtarı.

private const string GooglePlacesUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json";  // Yer aramaları için kullanılacak URL.

API Ayarları Ektikleştirilmesi gerekir.
Directions API
Geocoding API
Maps Javascript API


GooglePlacesUrl: Bu URL, yakın çevredeki yerleri aramak için kullanılacak Google Maps API'nin endpoint'idir. Yer aramaları genellikle kategori (restoran, hastane, vb.) veya koordinatlara göre yapılır.

Proje Hedefi:
Bu proje, kullanıcıların belirli bir konumda yakınlarındaki mekanları aramalarını sağlar. Arama sonuçlarında elde edilen iletişim bilgilerine toplu olarak mesaj gönderilir.
