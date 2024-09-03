import React, { useState, useEffect } from 'react';
import axios from 'axios';

const DataFetchingComponent = () => {
  // biome-ignore lint/suspicious/noExplicitAny: <explanation>
  const [data, setData] = useState<any>();
  // biome-ignore lint/suspicious/noExplicitAny: <explanation>
  const [error, setError] = useState<any>();
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // Define the async function to fetch data
    const fetchData = async () => {
      try {
        // Make the HTTP request using Axios
        const response = await axios.get('http://localhost:5000/controller/GetJourneys');
        // Set the data to state
        setData(response.data);
      } catch (error) {
        // If there's an error, set the error to state
        setError(error);
      } finally {
        // Set loading to false regardless of success or error
        setIsLoading(false);
      }
    };

    // Call the fetchData function
    fetchData();
  }, []); // The empty array ensures this effect runs only once on mount

  // Render loading, error, or data state to the user
  return (
    <div>
        <p>Tada</p>
    </div>
  );
};

export default DataFetchingComponent;