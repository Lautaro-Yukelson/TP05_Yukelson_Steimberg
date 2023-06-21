﻿var contPistas = 0;

document.addEventListener("keydown", (event) => {
  var codigo = event.which || event.keyCode;
  if (String.fromCharCode(codigo) == "P") {
    document.getElementById("pista").click();
    contPistas++;
    console.log(contPistas);
  }
});

document.addEventListener("DOMContentLoaded", function () {
  var items = document.querySelectorAll(".creditos__item");
  var currentItemIndex = 0;

  // Agregar la clase "active" al elemento actual
  function setActiveItem() {
    for (var i = 0; i < items.length; i++) {
      items[i].classList.remove("active");
    }
    items[currentItemIndex].classList.add("active");
  }

  // Manejar el evento de presionar una tecla
  document.addEventListener("keydown", function (event) {
    switch (event.key) {
      case "ArrowUp":
        if (currentItemIndex > 0) {
          currentItemIndex--;
        }
        break;
      case "ArrowDown":
        if (currentItemIndex < items.length - 1) {
          currentItemIndex++;
        }
        break;
    }
    setActiveItem();
  });

  // Agregar el evento a todos los elementos
  for (var i = 0; i < items.length; i++) {
    items[i].addEventListener("click", function () {
      currentItemIndex = Array.from(items).indexOf(this);
      setActiveItem();
    });
  }
});