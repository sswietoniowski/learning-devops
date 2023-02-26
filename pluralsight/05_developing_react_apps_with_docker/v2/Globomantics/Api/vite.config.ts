import { defineConfig } from 'vite';
import { VitePluginNode } from 'vite-plugin-node';

// https://vitejs.dev/config/
// https://www.npmjs.com/package/vite-plugin-node
export default defineConfig({
  server: {
    host: true,
    port: 3001,
  },
  plugins: [
    ...VitePluginNode({
      adapter: 'express',
      appPath: './src/server.ts',
      exportName: 'viteNodeApp',
      tsCompiler: 'esbuild',
    }),
  ],
  optimizeDeps: {},
});
