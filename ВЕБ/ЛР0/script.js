function vyvod() {
  var a = document.querySelector('.inp').value;
  document.querySelector('.out').innerHTML = a;
}

function registr(i){
  i=i+1;
  var a = document.querySelector('.inp').value;
  var arr = a.split('');
  
  var ab = arr.unshift('ф');
  arr[i]=arr[i].toUpperCase();
  arr[i-1]=arr[i-1].toLowerCase();
  ab = arr.shift();
  a = arr.join('');
  document.querySelector('.out').innerHTML = a;
}

function perebor(){
  var a = document.querySelector('.inp').value;
  for(let i = 0; i<a.length; i++){
    setTimeout(registr, 100*(i+1), i);
  }
}



//perebor();
//setTimeout(perebor, 1000);
setInterval(perebor, 1200);


// function grad(){
  
// }