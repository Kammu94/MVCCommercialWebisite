    app.controller("OrderController", function ($scope, $http) {
        $scope.addToCart = function (basket) {


            $http.post("/Order/AddToCart", basket).then(function (response) {

                alert("Inserted");
            });
        };
});
