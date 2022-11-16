const getBrowserName = () => {
    const userAgent = window.navigator.userAgent;

    if (userAgent.match(/Edg/i)) {
        return 'Edge';
    } else if (userAgent.match(/chrome|chromium|crios/i)) {
        return 'Chrome';
    } else if (userAgent.match(/firefox|fxios/i)) {
        return 'Firefox';
    } else if (userAgent.match(/opr\//i)) {
        return 'Opera';
    } else {
        return 'No browser detection';
    }
};

const result = getBrowserName();

// if (result !== 'Chrome') {
//     alert(
//         `Вы используете ${result} вместо Chrome, данная страница будет правильно отображаться только в данном браузере.`
//     );
// }

// if (result !== 'Firefox') {
//     alert(
//         `Вы используете ${result} вместо Firefox, данная страница будет правильно отображаться только в данном браузере.`
//     );
// }
