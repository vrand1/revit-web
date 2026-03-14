<template>
  <div v-if="false" />
</template>

<script setup>
import { onMounted, onBeforeUnmount } from 'vue'
import { useNotification } from 'naive-ui'

const notification = useNotification()

const handleMessage = (event) => {
  const data = event.data
  console.log(data)
  
  if (data.action === 'toast' && data.payload) {
    notification.create({
      type: 'info',
      title: data.payload.Title || 'Revit Event',
      content: data.payload.Message,
      duration: 4500,
      keepAliveOnHover: true
    })
  }
}

onMounted(() => {
  if (window.chrome?.webview) {
    window.chrome.webview.addEventListener('message', handleMessage)
    console.log('[Bridge] Listener attached')
  }
})

onBeforeUnmount(() => {
  if (window.chrome?.webview) {
    window.chrome.webview.removeEventListener('message', handleMessage)
  }
})
</script>