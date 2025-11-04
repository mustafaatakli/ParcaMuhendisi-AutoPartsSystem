import { createContext, useContext, useState } from 'react';

const NotificationContext = createContext();

export const useNotification = () => {
  const context = useContext(NotificationContext);
  if (!context) {
    throw new Error('useNotification must be used within a NotificationProvider');
  }
  return context;
};

export const NotificationProvider = ({ children }) => {
  const [notifications, setNotifications] = useState([]);

  const showNotification = (message, type = 'info') => {
    const id = Date.now();
    const notification = {
      id,
      message,
      type, // 'success', 'error', 'warning', 'info'
    };

    setNotifications((prev) => [...prev, notification]);

    // Auto remove after 4 seconds
    setTimeout(() => {
      removeNotification(id);
    }, 4000);
  };

  const removeNotification = (id) => {
    setNotifications((prev) => prev.filter((notif) => notif.id !== id));
  };

  const value = {
    notifications,
    showNotification,
    removeNotification,
    success: (message) => showNotification(message, 'success'),
    error: (message) => showNotification(message, 'error'),
    warning: (message) => showNotification(message, 'warning'),
    info: (message) => showNotification(message, 'info'),
  };

  return (
    <NotificationContext.Provider value={value}>
      {children}
    </NotificationContext.Provider>
  );
};
