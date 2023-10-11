import React, { useState, useEffect } from 'react';

const UserGreeting = () => {
    const [greeting, setGreeting] = useState();

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch('/api/greeting'); // <--- Lägg till authorization header i anropet (bearer token copy paste från slides)
                // hämta ut ID från user i api-controllern
                const data = await response.json();
                setGreeting(data.greeting);
            } catch (error) {
                console.error('Error fetching greeting:', error)
            }
        }
        fetchData();
    },[]);

return (
    <p>{greeting}</p>
);
};

export default UserGreeting;