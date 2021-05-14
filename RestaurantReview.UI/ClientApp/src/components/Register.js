var password = document.getElementById("password_input")
  , confirm_password = document.getElementById("passwordConfirm_input");

function validatePassword(){
  if(password.value != confirm_password.value) {
    confirm_password.setCustomValidity("Passwords does not match");
  } else {
    confirm_password.setCustomValidity('');
  }
  confirm_password.reportValidity();
}


password.addEventListener("change", validatePassword);
confirm_password.addEventListener("change", validatePassword);
