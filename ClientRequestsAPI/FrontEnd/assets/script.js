document.getElementById('clientRequestForm').addEventListener('submit', function(event) {
    event.preventDefault(); // Evita que el formulario se envíe de manera tradicional

    // Obtén los datos del formulario
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;
    const message = document.getElementById('message').value;

    // Crea un objeto con los datos
    const data = {
        name: name,
        email: email,
        phone: phone,
        message: message
    };

    // Realiza la solicitud POST a la API
    fetch('http://localhost:5024/api/ClientRequests/submit-client-data', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data) // Convierte el objeto en JSON
    })
    .then(response => {
        console.log('Estado de la respuesta:', response.status); // Muestra el código de estado
        if (!response.ok) {
            return response.json().then(errorData => {
                console.error('Detalles del error:', errorData);
                throw new Error('Error en la solicitud');
            });
        }
        return response.json(); // Convierte la respuesta en JSON
    })
    .then(data => {
        console.log('Éxito:', data);
        // Muestra una alerta de éxito
        Swal.fire({
            icon: 'success',
            title: 'Enviado',
            text: 'Tu mensaje ha sido enviado con éxito.',
            confirmButtonText: 'Aceptar'
        });
        // Limpia el formulario después de enviar
        document.getElementById('clientRequestForm').reset();
    })
    .catch(error => {
        console.error('Error:', error);
        // Muestra una alerta de error
        Swal.fire({
            icon: 'error',
            title: 'Error',
            text: 'Hubo un problema al enviar el mensaje. Por favor, intenta nuevamente.',
            confirmButtonText: 'Aceptar'
        });
    });
});
