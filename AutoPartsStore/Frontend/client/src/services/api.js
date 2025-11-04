import axios from 'axios';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5167/api';

const api = axios.create({
  baseURL: API_BASE_URL,
  headers: {
    'Content-Type': 'application/json',
  },
});

// Token'ı otomatik olarak tüm isteklere ekle
api.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem('token');
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

export const categoriesAPI = {
  getAll: () => api.get('/categories'),
  getById: (id) => api.get(`/categories/${id}`),
  getBySlug: (slug) => api.get(`/categories/slug/${slug}`),
};

export const brandsAPI = {
  getAll: () => api.get('/brands'),
  getById: (id) => api.get(`/brands/${id}`),
  getBySlug: (slug) => api.get(`/brands/slug/${slug}`),
};

export const partBrandsAPI = {
  getAll: () => api.get('/partbrands'),
  getById: (id) => api.get(`/partbrands/${id}`),
  getBySlug: (slug) => api.get(`/partbrands/slug/${slug}`),
};

export const productsAPI = {
  getAll: (params) => api.get('/products', { params }),
  getById: (id) => api.get(`/products/${id}`),
  getFeatured: () => api.get('/products/featured'),
  search: (query) => api.get(`/products/search?query=${query}`),
};

export const ordersAPI = {
  create: (orderData) => api.post('/orders', orderData),
  getByNumber: (orderNumber) => api.get(`/orders/number/${orderNumber}`),
};

export const adminAPI = {
  // Products
  getAllProducts: () => api.get('/admin/products'),
  createProduct: (productData) => api.post('/admin/products', productData),
  updateProduct: (id, productData) => api.put(`/admin/products/${id}`, productData),
  deleteProduct: (id) => api.delete(`/admin/products/${id}`),

  // Orders
  getAllOrders: () => api.get('/admin/orders'),
  updateOrderStatus: (id, status) => api.put(`/admin/orders/${id}/status`, { status }),

  // Stats
  getStats: () => api.get('/admin/stats'),

  // Users
  getAllUsers: () => api.get('/admin/users'),
};

export default api;
