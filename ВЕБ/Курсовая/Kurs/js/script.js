"use strict"

//меняем фото при редактировании
document.addEventListener('DOMContentLoaded', function () {

   const formPhoto = document.getElementById('user-photo');
   const formPhotoPreview = document.getElementById('user-photo-preview');

   formPhoto.addEventListener('change', () => {
      uploadFile(formPhoto.files[0]);
   });

   function uploadFile(file) {
      //Проверяем тип файла
      if (!['image/jpeg', 'image/png', 'image/jpg'].includes(file.type)) {
         alert("Разрешены только изображения");
         return;
      }

      //Проверяем размер файла
      if (file.size > 10 * 1024 * 1024) {
         alert("Файл должен быть меньше 2 МБ.");
         return;
      }

      var reader = new FileReader();
      reader.onload = function (e) {
         formPhotoPreview.innerHTML = `<img src="${e.target.result}" alt="Ваше фото">`;
      };
      reader.onerror = function (e) {
         alert("Ошибка!");
      }
      reader.readAsDataURL(file);
   }
});

function ibg() {

   let ibg = document.querySelectorAll(".ibg");
   for (var i = 0; i < ibg.length; i++) {
      if (ibg[i].querySelector('img')) {
         ibg[i].style.backgroundImage = 'url(' + ibg[i].querySelector('img').getAttribute('src') + ')';
      }
   }
}
ibg();
