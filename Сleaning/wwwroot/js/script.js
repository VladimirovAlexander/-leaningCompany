//калькулятор
function calculate() {
    var place = document.getElementById("place").value;
    var cleaningType = document.getElementById("cleaning-type").value;
    var additionalServices = [];
    var checkboxes = document.querySelectorAll('input[type="checkbox"]:checked');
    checkboxes.forEach(function (checkbox) {
        additionalServices.push(checkbox.value);
    });
    var area = parseFloat(document.getElementById("area").value);

    var basePrice = 0;
    // Цены на услуги (в рублях за квадратный метр)
    var prices = {
        "Поддерживающая": 100,
        "Генеральная": 150,
        "После ремонта": 200,
        "После пожара": 300,
        "Антибактериальная": 250,
        // Другие услуги добавьте сюда
    };

    // Базовая цена в зависимости от выбранного типа уборки
    if (prices[cleaningType]) {
        basePrice = prices[cleaningType] * area;
    }

    // Дополнительные услуги
    var additionalServicesPrice = 0;
    // Цены на дополнительные услуги (в рублях за квадратный метр)
    var additionalServicesPrices = {
        "Химчистка мебели": 50,
        "Химчистка ковра": 70,
        "Мытье окон": 30,
        "Глажка вещей": 20,
        // Другие услуги добавьте сюда
    };
    additionalServices.forEach(function (service) {
        if (additionalServicesPrices[service]) {
            additionalServicesPrice += additionalServicesPrices[service] * area;
        }
    });

    var totalPrice = basePrice + additionalServicesPrice;

    document.getElementById("result").innerHTML = "Стоимость уборки " + place + " (" + cleaningType + ") с учетом дополнительных услуг составляет: " + totalPrice + " рублей.";
}



//авторизация
// Функция открытия модального окна
// Функция открытия и закрытия модального окна
function toggleModal() {
    var modal = document.getElementById("myModal");
    var loginButton = document.getElementById("loginButton");
    if (modal.style.display === "none") {
        modal.style.display = "block";
        loginButton.textContent = "Выйти";
    } else {
        modal.style.display = "none";
        loginButton.textContent = "Войти";
    }
}

// Обработчик отправки формы
document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("loginForm").addEventListener("submit", function (event) {
        event.preventDefault(); // Предотвращаем стандартное действие формы (отправку)

        // Получаем значения логина и пароля из формы
        var username = document.getElementById("username").value;
        var password = document.getElementById("password").value;

        // Проверяем логин и пароль
        if (username === "admin" && password === "admin") {
            // Если логин и пароль совпадают с "admin", перенаправляем на admin.html
            window.location.href = "admin.html";
        } else {
            // В противном случае, перенаправляем на myProfile.html
            console.log(username);
            console.log(password);

            window.location.href = "myProfile.html";
        }

        // Закрываем модальное окно
        closeModal();
    });

    // Функция для закрытия модального окна
    function closeModal() {
        var modal = document.getElementById("myModal");
        modal.style.display = "none";
    }
});
