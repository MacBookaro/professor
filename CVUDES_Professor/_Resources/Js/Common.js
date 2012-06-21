// Prevenir la navegacion con los botones del navegador
//function preventBack(){window.history.forward();} 
//setTimeout("preventBack()", 0); 
//window.onunload=function(){null}; 

// Abrir ventanas
function openBrWindow(theURL, winName, features, myWidth, myHeight, isCenter) {
    if (window.screen) if (isCenter) if (isCenter == "true") {
        var myLeft = (screen.width - myWidth) / 2 - 15;
        var myTop = ((screen.height - myHeight) / 2) - 20;
        var newwindow;
        features += (features != '') ? ',' : '';
        features += ',left=' + myLeft + ',top=' + myTop;
    }
    newwindow = window.open(theURL, winName, features + ((features != '') ? ',' : '') + 'width=' + myWidth + ',height=' + myHeight);
    if (window.focus) {
        newwindow.focus()
    }
}

function openBrWindowFull(theURL, winName, features) {
    var isCenter = "true";
    if (window.screen) if (isCenter) if (isCenter == "true") {
        var myHeight = (screen.height - 250)
        var myWidth = (screen.width - 160)
        var myLeft = 80;
        var myTop = 100;
        var newwindow;
        features += (features != '') ? ',' : '';
        features += ',left=' + myLeft + ',top=' + myTop;
    }
    newwindow = window.open(theURL, winName, features + ((features != '') ? ',' : '') + 'width=' + myWidth + ',height=' + myHeight);
    if (window.focus) {
        newwindow.focus()
    }
}

// Mensaje de Cargando Pagina
function showLoading() {
    document.getElementById("divLoading").style.display = 'block';
}

function hideLoading() {
    setTimeout("hideLoadingNow()", 1000);
}

function hideLoadingNow() {
    document.getElementById("divLoading").style.display = 'none';
}

// Mensaje de Procesando Solicitud
function showProcessing() {
    document.getElementById("divProcessing").style.display = 'block';
}

function hideProcessing() {
    setTimeout("hideProcessingNow()", 500);
}

function hideProcessingNow() {
    document.getElementById("divProcessing").style.display = 'none';
}

function focusControl(objControl) {
    try {
        document.getElementById(objControl).focus();
    }
    catch (err)
    { }
}

function setModalPopUpFocus(webControl) {
    setTimeout("setFocus('" + webControl + "')", 1000);
}

function setFocus(webControl) {
    try {
        eval("document.getElementById('" + webControl + "').focus()");
    }
    catch (e) {
        alert("Modal Popup Error : " + webControl + ".")
    }
}

// Menu Principal
function swapIt(o, content, className, navigation, container) {
    //
	o.blur(); //Esto quita el foco de la pesta?a a la que le hicieron click
	
	if (o.className == className) return false;
	var list = document.getElementById(navigation).getElementsByTagName("li");
	
	for (var i = 0; i < list.length; i++) {
	    if (list[i].className == className) {
			list[i].className = "";
		}else {
		    if (list[i].className.search(className) >= 0) {
		        list[i].className = list[i].className.replace(className , '');
            }
		}
	}	
  	o.parentNode.className = o.parentNode.className + ' ' + className;  	
	list = document.getElementById(container).childNodes;
	for (var i = 0; i < list.length; i++) {
		if (list[i].tagName == "DIV") {
		   list[i].style.display = "none";
		}
	}    
	if(document.getElementById(content)){   
	   var top = document.getElementById(content);
	   top.style.display = "block";
    }
	return false;
}  