![image](https://github.com/user-attachments/assets/f1e0811d-1620-46ff-a561-d02f3e495ef1)

Google Maps to WhatsApp Project
This project offers an application that aims to find places near a user and share this information via WhatsApp using Google Maps API and WhatsApp API integration. Below you will find an important part of the project's operation.

Technologies Used:
Google Places API: Used to search for places.

WhatsApp API: Used to share information about the found places via WhatsApp.

Code Description:
The following constants contain the API key required for searches to be made with Google Maps API and the URL where we will send requests to the API:

private const string GoogleApiKey = "API_KEY"; // Here, the Google Maps API key.

private const string GooglePlacesUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json"; // URL to be used for place searches.

API Settings Must be enabled.
Directions API
Geocoding API
Maps Javascript API

GooglePlacesUrl: This URL is the endpoint of the Google Maps API that will be used to search for nearby places. Place searches are usually done by category (restaurant, hospital, etc.) or coordinates.

Project Goal:
This project allows users to search for places near a specific location. Mass messages are sent to the contact information obtained from the search results.

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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

