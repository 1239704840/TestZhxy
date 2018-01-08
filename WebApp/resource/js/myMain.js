function setCookie(name, value) {
    document.cookie = name + '=' + escape(value);
}
function loginOrRegister() {
    if (Session["UserName"]!= null) {
        Response.Redirect("index.aspx");
    } else {
        Response.Redirect("register.aspx");
    }
}
