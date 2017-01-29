angular.module('app', [])
    .controller('HomeCtrl', function ($scope, $http) {
        
        $scope.text = "ali kemal";

        $scope.nextQuestion = function () {
            $scope.text = "ali veli";
            $http.get("/api/message").success(function (data, status, headers, config) {
                $scope.text = data;
            }).
            error(function (data, status, headers, config) {
                $scope.text = "error";
            });
         };
    });