app.controller("BasketController", function ($scope, $http) {
    $scope.addToCart = function (basket) {


        $http.post("/Basket/AddToCart", basket).then(function (response) {

            $scope.getUserBasket(basket.productId);
            alert("Inserted");
        });
    };
    $scope.getUserBasket = function (productId) {
        $http.post("/Basket/GetUserBasket", productId).then(function (response) {
            $scope.basketItems = response.data;

            alert("Get Successfully.");
        });
    };
});
