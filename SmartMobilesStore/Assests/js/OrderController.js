    app.controller("OrderController", function ($scope, $http) {
    $scope.addToCart = function (prod) {

        $http.post("/Order/AddToCart").then(function (response) {

            alert("Inserted")
        });
    }
});
