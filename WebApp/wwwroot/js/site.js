function showHideElement(elementId) {
	const element = document.getElementById(elementId);
	console.log(element);
	console.log(element.style.display);
	console.log(element.style.display.includes("none"));

	if (element.style.display.includes("none"))
		element.setAttribute('style', 'display:flex !important');
	else
		element.setAttribute('style', 'display:none !important');
}

function openNav() {
	document.getElementById("mySidenav").style.width = "250px";
	document.getElementById("main").style.marginLeft = "250px";
}
function closeNav() {
	document.getElementById("mySidenav").style.width = "0";
	document.getElementById("main").style.marginLeft = "0";
}

$(".alert").alert();
window.setTimeout(function () { $(".alert").alert('close'); }, 2000);