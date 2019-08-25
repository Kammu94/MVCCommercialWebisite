app.controller("UserAccountController", function ($scope, $http) {


    $scope.LoginDetailsList = [];



    $scope.validateLogin = function (credentials) {
      
        $http.post("/Account/GetLoginDetails", { Email: credentials.email, Password: credentials.password }).then(function (response) {

            $scope.LoginDetailsList = response.data;
            
            if ($scope.LoginDetailsList[0].Message == "Login Successfull") {
                $("#login").modal();
                $scope.loginmessage = "Login Successfull";
                window.location.assign("Homepage")

            }
            else if ($scope.LoginDetailsList[0].Message == "Your Password was incorrect") {
                $("#login").modal();
                $scope.loginmessage = "Your Password was incorrect.";
            }
            else {
                $("#login").modal();
                $scope.loginmessage = "Your Email was incorrect.";

            }
          }

        )


    }

    $scope.validateAdminLogin = function (login)
    {
        if (login.email == null && login.email == 'undefined' && login.password == null && login.password == 'undefined') {
            alert("Mandatory fields are required");
            return
        }
        $http.post("/Account/AdminLogin", { Email: login.email, Password: login.password }).then(function (response) {

            if (response.data.isValid == true) {
                alert("Login Successfull")
                location.assign("http://localhost:56424/Admin/AddProduct")
            }
            else {
                alert("Wrong credentials")
                location.assign("http://localhost:56424/Admin/Login")}
        })

    }

   

});