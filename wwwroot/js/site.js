document.addEventListener('keydown', (event) => {
    var codigo = event.which || event.keyCode;
    /*console.log(String.fromCharCode(codigo));*/
    if (String.fromCharCode(codigo) == "P"){
        document.getElementById('pista').click();
    }
  });