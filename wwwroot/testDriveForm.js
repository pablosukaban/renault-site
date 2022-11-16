const onSubmit = () => {
    const mail = document.getElementById('email');
    const phone = document.getElementById('phone');

    if (
        document.getElementById('saloon').value !== 'г. Москва' &&
        document.getElementById('saloon').value !== 'г. Санкт-Петербург'
    ) {
        alert('Неправильно введен салон');
        return false;
    }

    if (phone.value.length !== 12 && phone.value[0] !== '+') {
        alert('Неправильно введен номер телефона');
        return false;
    }

    // window.open('mailto:' + mail.value)
};
