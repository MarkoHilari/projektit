function faultCode() {
  let formi = document.forms[0];
  let model = formi.model.value;
  let fault = formi.fault.value;
  let type = formi.type.value;
  let tulosta = "Model= " + model + "vika " + fault + "tyyppi " + type;

  document.getElementById('tulos').innerHTML = tulosta;
}
