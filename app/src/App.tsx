import React, { useEffect } from 'react';
import axios from 'axios';
import { Button } from 'antd';
import create from 'zustand';
import Layout from './interfaces/ui/components/Layout/Layout';

// Define your state using Zustand
type AppState = {
  data: string[];
  addData: (datum: string) => void;
};

const useStore = create<AppState>((set) => ({
  data: [],
  addData: (datum) => set((state) => ({ data: [...state.data, datum] }))
}));

const App: React.FC = () => {
  const data = useStore((state) => state.data);
  const addData = useStore((state) => state.addData);

  

  useEffect(() => {
    // Make an API call when the component mounts
    axios.get('/api/weatherforecast')
      .then(response => {
        console.log(response.data);
      })
      .catch(error => {
        console.error('There was an error fetching data:', error);
      });
  }, []);  // Empty dependency array means this useEffect runs once when the component mounts


  return (
    <Layout>
    <div className="app-container">
      <h1>DataDive Den</h1>
      <Button type="primary" onClick={() => addData(`Data ${data.length + 1}`)}>
        Add Data
      </Button>
      <ul>
        {data.map((datum, index) => (
          <li key={index}>{datum}</li>
        ))}
      </ul>
    </div>
    </Layout>
  );
};

export default App;
