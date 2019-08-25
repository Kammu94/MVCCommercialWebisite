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

   

});