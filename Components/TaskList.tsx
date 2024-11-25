import React, { useEffect, useState } from 'react';
import { getTasks } from '../services/TaskService';

const TaskList: React.FC = () => {
    const [tasks, setTasks] = useState([]);

    useEffect(() => {
        getTasks().then((response) => {
            setTasks(response.data);
        });
    }, []);

    return (
        <div>
            <h1>Task List</h1>
            <ul>
                {tasks.map((task: any) => (
                    <li key={task.id}>
                        {task.title} - {task.isCompleted ? 'Completed' : 'Pending'}
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default TaskList;
