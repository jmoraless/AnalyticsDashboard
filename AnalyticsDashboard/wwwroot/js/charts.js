window.chartInterop = {
    // Gráfico de líneas
    renderLineChart: (canvasId, title, labels, data, labelName) => {
        console.log('renderLineChart called:', canvasId, labels, data);

        const canvas = document.getElementById(canvasId);
        if (!canvas) {
            console.error('Canvas not found:', canvasId);
            return;
        }

        const ctx = canvas.getContext('2d');

        // Destruir gráfico existente si hay
        if (window[canvasId]) {
            window[canvasId].destroy();
        }

        window[canvasId] = new Chart(ctx, {
            type: 'line',
            data: {
                labels: labels,
                datasets: [{
                    label: labelName,
                    data: data,
                    borderColor: 'rgb(54, 162, 235)',
                    backgroundColor: 'rgba(54, 162, 235, 0.1)',
                    tension: 0.1,
                    fill: true
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: true,
                plugins: {
                    title: {
                        display: true,
                        text: title
                    }
                }
            }
        });

        console.log('Chart created successfully');
    },

    // Gráfico de barras
    renderBarChart: (canvasId, title, labels, data, labelName) => {
        console.log('renderBarChart called:', canvasId);

        const canvas = document.getElementById(canvasId);
        if (!canvas) {
            console.error('Canvas not found:', canvasId);
            return;
        }

        const ctx = canvas.getContext('2d');

        if (window[canvasId]) {
            window[canvasId].destroy();
        }

        window[canvasId] = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: labels,
                datasets: [{
                    label: labelName,
                    data: data,
                    backgroundColor: 'rgba(54, 162, 235, 0.6)',
                    borderColor: 'rgb(54, 162, 235)',
                    borderWidth: 1
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: true,
                plugins: {
                    title: {
                        display: true,
                        text: title
                    }
                }
            }
        });
    },

    // Gráfico comparativo
    renderComparisonChart: (canvasId, title, labels, otsData, watcherData) => {
        console.log('renderComparisonChart called:', canvasId);

        const canvas = document.getElementById(canvasId);
        if (!canvas) {
            console.error('Canvas not found:', canvasId);
            return;
        }

        const ctx = canvas.getContext('2d');

        if (window[canvasId]) {
            window[canvasId].destroy();
        }

        window[canvasId] = new Chart(ctx, {
            type: 'line',
            data: {
                labels: labels,
                datasets: [
                    {
                        label: 'OTS',
                        data: otsData,
                        borderColor: 'rgb(54, 162, 235)',
                        backgroundColor: 'rgba(54, 162, 235, 0.1)',
                        tension: 0.1,
                        fill: false
                    },
                    {
                        label: 'Watchers',
                        data: watcherData,
                        borderColor: 'rgb(255, 99, 132)',
                        backgroundColor: 'rgba(255, 99, 132, 0.1)',
                        tension: 0.1,
                        fill: false
                    }
                ]
            },
            options: {
                responsive: true,
                maintainAspectRatio: true,
                plugins: {
                    title: {
                        display: true,
                        text: title
                    }
                }
            }
        });
    },

    // Gráfico de pastel
    renderPieChart: (canvasId, title, labels, data) => {
        console.log('renderPieChart called:', canvasId, labels, data);

        const canvas = document.getElementById(canvasId);
        if (!canvas) {
            console.error('Canvas not found:', canvasId);
            return;
        }

        const ctx = canvas.getContext('2d');

        if (window[canvasId]) {
            window[canvasId].destroy();
        }

        window[canvasId] = new Chart(ctx, {
            type: 'pie',
            data: {
                labels: labels,
                datasets: [{
                    data: data,
                    backgroundColor: [
                        'rgb(255, 99, 132)',
                        'rgb(54, 162, 235)',
                        'rgb(255, 205, 86)',
                        'rgb(75, 192, 192)',
                        'rgb(153, 102, 255)'
                    ]
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: true,
                plugins: {
                    title: {
                        display: true,
                        text: title
                    },
                    legend: {
                        position: 'bottom'
                    }
                }
            }
        });
    }
};