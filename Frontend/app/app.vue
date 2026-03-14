<template>
  <n-config-provider :theme="darkTheme">
    <n-notification-provider placement="bottom-right">
      <n-message-provider placement="bottom-right">
        <NuxtLayout>
          <div class="layout">
            <NuxtPage />
          </div>
        </NuxtLayout>
        <RevitBridgeListener />
      </n-message-provider>
    </n-notification-provider>
  </n-config-provider>
</template>

<script setup>
import { darkTheme } from 'naive-ui'
</script>