let count = 0;
let temp = [];
function faultCode() {
  for(var i = 0; i < localStorage.length; i++)
  {
    temp[i] = localStorage.getItem(localStorage.key(i));
    console.log(temp[i]);
  }

  count++;
  alert("count = " + count);
  let id = count;
  let brand = document.getElementById('brand').value;
  let model = document.getElementById('model').value;
  let fault = document.getElementById('fault').value;
  let type = document.getElementById('type').value;
  let tulosta =  "<b>ID: </b>" + id + "<b>Merkki: </b>" + brand + " <br> <b>Malli: </b>" + model +  "<br><b> Vika: </b>" + fault + "<br><b> Tyyppi: </b>" + type;

  document.getElementById('tulos').innerHTML = tulosta;

let car = {
  id: id,
  merkki: brand,
  malli: model,
  vika: fault,
  Tyyppi: type,
}
window.localStorage.setItem(id, JSON.stringify(car));
//document.getElementById('brand').innerHTML = "";
document.getElementById('model').value = "";
document.getElementById('fault').value = "";
document.getElementById('type').value = "";
document.getElementById('brand').value = "";

//window.localStorage.setItem(arvo, count);
}
