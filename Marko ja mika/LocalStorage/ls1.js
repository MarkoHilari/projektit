function faultCode() {
/*  let count = localStorage.getItem(arvo);
  count++;
  alert("count = " + count);*/
  let brand = document.getElementById('brand').value;
  let model = document.getElementById('model').value;
  let fault = document.getElementById('fault').value;
  let type = document.getElementById('type').value;
  let tulosta =  "<b>Merkki: </b>" + brand + " <br> <b>Malli: </b>" + model +  "<br><b> Vika: </b>" + fault + "<br><b> Tyyppi: </b>" + type;

  document.getElementById('tulos').innerHTML = tulosta;

let car = {
  merkki: brand,
  malli: model,
  vika: fault,
  Tyyppi: type,
}
window.localStorage.setItem(brand, JSON.stringify(car));
//window.localStorage.setItem(arvo, count);
}
