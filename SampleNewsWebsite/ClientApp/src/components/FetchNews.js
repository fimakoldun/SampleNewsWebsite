import React, { useEffect, useState } from 'react';
import authService from './api-authorization/AuthorizeService';

const ForecastsTable = (forecasts) => {
    return (
        <table className='table table-striped' aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Title</th>
                    <th>Author</th>
                </tr>
            </thead>
            <tbody>
                {forecasts.map(forecast =>
                    <tr key={forecast.id}>
                        <td>{forecast.title}</td>
                        <td>{forecast.creator.userName}</td>
                    </tr>
                )}
            </tbody>
        </table>
    );
}

export const FetchNewsData = () => {
    const [forecasts, setForecasts] = useState([]);

    useEffect(() => {
        const populateNewsData = async () => {
            const token = await authService.getAccessToken();
            const response = await fetch('news/index', {
                headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
            });
            const data = await response.json();
            setForecasts(data);
        }

        populateNewsData()
    }, []);

    return (
        <div>
            <h1 id="tabelLabel" >Weather forecast</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {ForecastsTable(forecasts)}
        </div>
    );
}
