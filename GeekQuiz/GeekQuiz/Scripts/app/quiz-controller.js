var QuizApp = angular.module('QuizApp', ['ngAnimate']);

QuizApp.controller('QuizCtrl', function ($scope, $http) {
    $scope.Documents = [];

    $scope.answer = function () {
        return $scope.correctAnswer ? 'correct' : 'incorrect';
    };

    $scope.nextQuestion = function () {

        $http.get("/api/documents").success(function (data, status, headers, config) {
            $scope.Documents = data;
            $scope.Documents.imagePath = $scope.Documents.imagePath
            $scope.documentOrder = 'documentType';

        }).error(function (data, status, headers, config) {
            $scope.title = "Oops... something went wrong";
            $scope.working = false;
        });

       
    };

    $scope.sendAnswer = function (documentType, documentNo, firstName, lastName, validFrom, validTill, imagePath) {
        $scope.working = true;
        $scope.answered = true;

        $http.post('/api/documents', { 'documentType': documentType, 'documentNumber': documentNo, 'firstName': firstName, 'lastName': lastName, 'validFrom': validFrom, 'validTill': validTill, 'imagePath': imagePath }).success(function (data, status, headers, config) {
            
            window.location.href = 'Index';

        }).error(function (data, status, headers, config) {
            $scope.title = "Oops... something went wrong";
            $scope.working = false;
        });
    };

});





//QuizApp.config(['$routeProvider', function ($routeProvider) {
//    $routeProvider.
//    when('/Index', {
//        templateUrl: 'partials/list.html',
//        controller: 'QuizCtrl'
//    }).
//    when('/details/:itemId', {
//        templateUrl: 'partials/details.html',
//        controller: 'QuizCtrl'
//    }).
//    otherwise({
//        redirectTo: '/list'
//    });
//}]);