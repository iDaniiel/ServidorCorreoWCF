const nodemailer = require('nodemailer');

let transport = nodemailer.createTransport({
    host: 'smtp.gmail.com',
    port: '587',
    auth: {
        user: 'idaniiel.testing.16@gmail.com',
        pass: 'Micontrasenaes#25'
    }
});

const message = {
    from: 'idaniiel.testing.16@gmail.com',
    to: 'idaniiel@live.com.mx',
    subject: 'Prueba',
    //text: 'Este es un correo de prueba y esto es el cuerpo'
    html: '<h1>Este es un encabezado de prueba</h1><p>y esto es un parrafo en la prueba</p>',
    attachments: [
        {
            filename: 'your-testla.png',
            path: 'https://media.gettyimages.com/photos/view-of-tesla-model-s-in-barcelona-spain-on-september-10-2018-picture-id1032050330?s=2048x2048'
        }
    ]
};

transport.sendMail(message, function(err, info) {
    if(err){
        console.log(err)
    }else {
        console.log(info)
    }
});

