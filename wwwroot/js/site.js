var pulsado = false;

document.addEventListener("DOMContentLoaded", function () {
  // Agregar la clase "active" al elemento actual
  function setActiveItem() {
    if (pulsado){
      for (let i = 0; i < itemsMenu.length; i++) {
        itemsMenu[i].classList.remove("active");
      }
    } else {
      for (let i = 0; i < items.length; i++) {
        items[i].classList.remove("active");
      }
    }
    if (pulsado) {
      itemsMenu[currentItemIndex].classList.add("active");
    } else {
      items[currentItemIndex].classList.add("active");
    }
  }

  // Pido los items
  let items = document.querySelectorAll(".creditos__item");
  let itemsMenu = document.querySelectorAll(".menu__item");
  let currentItemIndex = 0;

  // Manejar el evento de presionar una tecla
  document.addEventListener("keydown", (event) => {
    let codigo = event.which || event.keyCode;
    let activeElement = document.activeElement;
    let isInput = activeElement.tagName === "INPUT";

    console.log(event.key);

    if (!isInput) {
      switch (event.key.toUpperCase()) {
        case "ESCAPE":
          pulsado = !pulsado;
          document.getElementById("pausa").click();
          break;
        case "P":
          document.getElementById("pista").click();
          break;
        case "ARROWUP":
          if (currentItemIndex > 0) {
            currentItemIndex--;
          }
          setActiveItem();
          break;
        case "ARROWDOWN":
          if (pulsado && currentItemIndex < itemsMenu.length - 1) {
            currentItemIndex++;
          } else if (!pulsado && currentItemIndex < items.length - 1) {
            currentItemIndex++;
          }
          setActiveItem();
          break;
      }
    }
  });

  // Agregar el evento a todos los elementos
  for (let i = 0; i < items.length; i++) {
    items[i].addEventListener("click", function () {
      currentItemIndex = Array.from(items).indexOf(this);
      setActiveItem();
    });
  }

  // Enviar form con boton fachero
  let boton = document.querySelector(".submit");
  let btnEnviar = document.getElementById("btnEnviar");

  boton.addEventListener("click", function () {
    btnEnviar.click();
  });
});

var selectedHour = 0;
function setTime(timeType, value) {
  if (timeType == "hour") {
    selectedHour = value;
    document.getElementById("hourNumbers").style.display = "none";
    document.getElementById("minuteNumbers").style.display = "flex";
  } else if (timeType == "minute") {
    const timeInput = document.getElementById("appt");
    const date = new Date();
    date.setHours(selectedHour);
    date.setMinutes(value);
    const formattedTime = date.toTimeString().slice(0, 5);
    timeInput.value = formattedTime;
    document.getElementById("send").click();
  }
}