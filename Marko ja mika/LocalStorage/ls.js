const opelForm = document.getElementById('opelForm');
const opelsContainer = document.querySelector('.opels');
const modelInput = opelForm['model']
const faultInput = opelForm['fault']
const typeInput = opelForm['type']



const opels = JSON.parse(localStorage.getItem("opels")) || [];

const addModel = (model, fault, type) => {
  opels.push({
    model,
    fault,
    type
  });

  localStorage.setItem("opels", JSON.stringify(opels))

  return {model, fault, type};
};

const createModelElement = ({model, fault, type}) => {
  const opelDiv = document.createElement('div');
  const opelModel = document.createElement('h2')
  const opelFault = document.createElement('p')
  const opelType = document.createElement('p')

  opelModel.innerText = "Auton malli: " + model
  opelFault.innerText = "Auton vika: " + fault;
  opelType.innerText = "Auton tyyppi: " + type;

  opelDiv.append(opelModel, opelFault, opelType);
  opelsContainer.appendChild(opelDiv);

  opelsContainer.style.display = opels.length === 0 ? "none" : "flex";
};

opelsContainer.style.display = opels.length === 0 ? "none" : "flex";

opels.forEach(createModelElement);

opelForm.onsubmit = (e) => {
  e.preventDefault();

  const newModel = addModel(
    modelInput.value,
    faultInput.value,
    typeInput.value
  );
  createModelElement(newModel)

  modelInput.value = "";
  faultInput.value = "";
  typeInput.value = "";
};
